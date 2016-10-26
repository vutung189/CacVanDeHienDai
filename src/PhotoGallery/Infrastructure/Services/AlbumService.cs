using PhotoGallery.Entities;
using PhotoGallery.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;

namespace PhotoGallery.Infrastructure.Services
{
    public class AlbumService : IAlbumService
    {
        #region Variables
        private readonly IAlbumRepository _albumRepository;
        #endregion
        public AlbumService(IAlbumRepository albumRepository)
        {
            _albumRepository = albumRepository;
        }




        public Album CreateAlbum(string title, string description, int user_ID)
        {
            var album = new Album() {
                Title = title,
                Description = description,
                DateCreated = DateTime.Now
                //User_ID = user_ID
            };

            _albumRepository.Add(album);
            _albumRepository.Commit();
            return album;
        }

        public Album GetAlbum(int albumID)
        {
            return _albumRepository.GetSingle(albumID);
        }

    }
}
