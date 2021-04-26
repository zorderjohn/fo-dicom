// Copyright (c) 2012-2020 fo-dicom contributors.
// Licensed under the Microsoft Public License (MS-PL).

using System;

using System.ComponentModel.Composition.Hosting;

using System.IO;
using System.Reflection;

using Dicom.Log;

namespace Dicom.Imaging.Codec
{
    /// <summary>
    /// Implementation of <see cref="TranscoderManager"/> for Windows desktop (.NET) applications.
    /// </summary>
    public sealed class DesktopTranscoderManager : TranscoderManager
    {
        #region FIELDS

        /// <summary>
        /// Singleton instance of the <see cref="DesktopTranscoderManager"/>.
        /// </summary>
        public static readonly TranscoderManager Instance;

        #endregion

        #region CONSTRUCTORS

        /// <summary>
        /// Initializes the static fields of <see cref="DesktopTranscoderManager"/>.
        /// </summary>
        static DesktopTranscoderManager()
        {
            Instance = new DesktopTranscoderManager();
        }

        /// <summary>
        /// Initializes an instance of <see cref="DesktopTranscoderManager"/>.
        /// </summary>
        public DesktopTranscoderManager()
        {
            this.LoadCodecsImpl(null, null);
        }

        #endregion

        #region METHODS

        /// <summary>
        /// Implementation of method to load codecs from assembly(ies) at the specified <paramref name="path"/> and 
        /// with the specified <paramref name="search"/> pattern.
        /// </summary>
        /// <param name="path">Directory path to codec assemblies.</param>
        /// <param name="search">Search pattern for codec assemblies.</param>
        protected override void LoadCodecsImpl(string path, string search)
        {
            IDicomCodec c;
            c = new dicomjp();
            c = new DicomJpeg2000LosslessCodec();
            Codecs[c.TransferSyntax] = c;

            c = new DicomJpeg2000LossyCodec();
            Codecs[c.TransferSyntax] = c;

            c = new DicomRleCodecImpl();
            Codecs[c.TransferSyntax] = c;
        }

        #endregion
    }
}
