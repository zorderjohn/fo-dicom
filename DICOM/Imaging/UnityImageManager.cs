// Copyright (c) 2010-2017 Anders Gustafsson, Cureos AB.
// All rights reserved. Any unauthorised reproduction of this 
// material will constitute an infringement of copyright.

namespace Dicom.Imaging
{
    /// <summary>
    /// Unity3D based image manager implementation.
    /// </summary>
    public class UnityImageManager : ImageManager
    {
        #region FIELDS

        /// <summary>
        /// Single instance of the Unity3D image manager.
        /// </summary>
        public static readonly ImageManager Instance;

        #endregion

        #region CONSTRUCTORS

        /// <summary>
        /// Initializes the static fields of <see cref="UnityImageManager"/>
        /// </summary>
        static UnityImageManager()
        {
            Instance = new UnityImageManager();
        }

        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets whether or not this type is classified as a default manager.
        /// </summary>
        public override bool IsDefault => true;

        #endregion

        #region METHODS

        /// <summary>
        /// Create <see cref="IImage"/> object using the current implementation.
        /// </summary>
        /// <param name="width">Image width.</param>
        /// <param name="height">Image height.</param>
        /// <returns><see cref="IImage"/> object using the current implementation.</returns>
        protected override IImage CreateImageImpl(int width, int height)
        {
            return new UnityImage(width, height);
        }

        #endregion
    }
}
