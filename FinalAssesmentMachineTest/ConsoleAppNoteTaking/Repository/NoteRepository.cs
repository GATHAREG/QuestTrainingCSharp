using ConsoleAppNoteTaking.Model;
using ConsoleAppNoteTaking.Settings;
using log4net;
using log4net.Appender;
using log4net.Config;
using log4net.Core;
using log4net.Layout;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppNoteTaking.Repository
{
    internal class NoteRepository : IStorageNote
    {
        private readonly SqlConnection _connection;
        private static readonly ILog logger = Logging.ConfigureLogging(typeof(NoteRepository));

        public NoteRepository()
        {
            _connection = new SqlConnection(AppSettings.ConnectionString);

        }

        
        public void AddNote(Note note)
        {
            try
            {
                EnsureConnectionIsOpen();
                var query = $"INSERT INTO Note(title,content,createdAt,updatedAt) values(@title,@content,@createdAt,@updatedAt)";
                var command = new SqlCommand(query, _connection);
                command.Parameters.AddWithValue("@title", note.Title);
                command.Parameters.AddWithValue("@content", note.Content);
                command.Parameters.AddWithValue("@createdAt", note.CreatedAt);
                command.Parameters.AddWithValue("@updatedAt",note.UpdatedAt);
                command.ExecuteNonQuery();
                logger.Info($"Note Added Successfully as {note.Title} ");
            }
            catch (Exception ex)
            {
                logger.Error("Error in adding");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                {
                    _connection.Close();
                }
            }


        }

        public void Delete(int id)
        {
            try
            {
                EnsureConnectionIsOpen();
                var query = $"DELETE FROM Note where noteId = @id";
                var command = new SqlCommand(query, _connection);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
                logger.Info($"Note  with {id} deleted successfully ");
            }
            catch(Exception ex)
            {
                logger.Error("Error while deleting note");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                {
                    _connection.Close();
                }
            }

        }

        public List<Note> GetAll()
        {
            var notes = new List<Note>();
            try
            { 
                EnsureConnectionIsOpen();
                var query = $"Select noteId,title,Content,CreatedAt from Note";
                var command = new SqlCommand(query, _connection);
                var reader = command.ExecuteReader();
            
                while (reader.Read())
                {
                    notes.Add(new Note
                    {
                        Id = reader.GetInt32(0),
                        Title = reader.GetString(1),
                        Content = reader.GetString(2),
                        CreatedAt = reader.GetDateTime(3),
                    });


                }
                
            }
            catch (Exception ex)
            {
                logger.Error("Error while viewing");
                Console.WriteLine(ex.Message);
              
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                {
                    _connection.Close();
                }
            }
            return notes;

        }
        public Note GetById(int id)
        {
            try
            {
                EnsureConnectionIsOpen();
                var query = $"SELECT noteId, title, content, createdAt, updatedAt FROM Note WHERE noteId = @id";
                var command = new SqlCommand(query, _connection);
                command.Parameters.AddWithValue("@id", id);

                var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return new Note
                    {
                        Id = reader.GetInt32(0),
                        Title = reader.GetString(1),
                        Content = reader.GetString(2),
                        CreatedAt = reader.GetDateTime(3),
                        UpdatedAt = reader.GetDateTime(4)
                    };
                }
                else
                {
                    logger.Warn($"No note with id{id}");
                    Console.WriteLine("No note with that ID.");
                    return new Note();
                }
            }
            catch (Exception ex)
            {
                logger.Error("Error while getting note");
                Console.WriteLine(ex.Message);
                return new Note();
                
            }
            finally
            {
                if(_connection.State == ConnectionState.Open)
                {
                    _connection.Close();
                }
            }


        }
        public List<Note> SearchNotes(string word)
        {
            var notes = new List<Note>();
            try
            {
                EnsureConnectionIsOpen();
                var query = "SELECT noteId, title, content, createdAt, updatedAt FROM Note WHERE title LIKE @word OR content LIKE @word";
                var command = new SqlCommand(query, _connection);
                command.Parameters.AddWithValue("@word", $"%{word}%");

                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    notes.Add(new Note
                    {
                        Id = reader.GetInt32(0),
                        Title = reader.GetString(1),
                        Content = reader.GetString(2),
                        CreatedAt = reader.GetDateTime(3),
                        UpdatedAt = reader.GetDateTime(4)
                    });
                }
            }
            catch (Exception ex)
            {
                logger.Error("Error while getting notes");
                Console.WriteLine($"Error during search: {ex.Message}");
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                {
                    _connection.Close();
                }
            }
            return notes;
        }

        public void Update(Note note)
        {
            try
            {
                EnsureConnectionIsOpen();
                var query = $"Update Note set title = @title, content =@content,updatedAt= @updatedAt where noteId = @id";
                var command = new SqlCommand(query, _connection);
                command.Parameters.AddWithValue("@title", note.Title);
                command.Parameters.AddWithValue("@content", note.Content);
                command.Parameters.AddWithValue("@updatedAt", note.UpdatedAt);
                command.Parameters.AddWithValue("@id", note.Id);
                command.ExecuteNonQuery();
                logger.Info("Note updated successfully");
            }
            catch(Exception ex)
            {
                logger.Error("Error while updating");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                {
                    _connection.Close();
                }
            }
        }

        private void EnsureConnectionIsOpen()
        {
            if (_connection.State != ConnectionState.Open)
            {
                _connection.Open();
            }

        }
    }
}
