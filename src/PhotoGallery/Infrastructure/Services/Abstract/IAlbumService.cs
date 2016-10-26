using PhotoGallery.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoGallery.Infrastructure.Services
{
    public interface IAlbumService
    {

        Album CreateAlbum(string Title, string Description, int User_ID);
        Album GetAlbum(int albumID);
    }
}
