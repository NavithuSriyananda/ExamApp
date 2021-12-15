using ExamApp.Api.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExamApp.Api.Controllers
{
    public class ImageController : ControllerBase
    {
        private List<Image> Images = new List<Image>();

        /// <summary>
        ///     Returns all images
        /// </summary>
        public List<Image> Get()
        {
            try
            {
                return Images;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        ///     Adds an image
        /// </summary>
        public void Add(Image img)
        {
            try
            {
                Images.Add(img);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        ///     Modifies an existing image
        /// </summary>
        public void Modify(Image img)
        {

        }

        /// <summary>
        ///     Removes an existing image
        /// </summary>
        public void Remove(Image img)
        {

        }
    }
}
