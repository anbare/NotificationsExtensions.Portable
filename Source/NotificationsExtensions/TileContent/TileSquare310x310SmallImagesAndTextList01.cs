﻿namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    using System;

    internal class TileSquare310x310SmallImagesAndTextList01 : TileSquare310x310Base, ITileSquare310x310SmallImagesAndTextList01, ISquare310x310TileNotificationContent, ITileNotificationContent, INotificationContent
    {
        public TileSquare310x310SmallImagesAndTextList01() : base("TileSquare310x310SmallImagesAndTextList01", null, 3, 9)
        {
        }

        public INotificationContentImage Image1
        {
            get
            {
                return base.Images[0];
            }
        }

        public INotificationContentImage Image2
        {
            get
            {
                return base.Images[1];
            }
        }

        public INotificationContentImage Image3
        {
            get
            {
                return base.Images[2];
            }
        }

        public INotificationContentText TextBodyGroup1Field1
        {
            get
            {
                return base.TextFields[1];
            }
        }

        public INotificationContentText TextBodyGroup1Field2
        {
            get
            {
                return base.TextFields[2];
            }
        }

        public INotificationContentText TextBodyGroup2Field1
        {
            get
            {
                return base.TextFields[4];
            }
        }

        public INotificationContentText TextBodyGroup2Field2
        {
            get
            {
                return base.TextFields[5];
            }
        }

        public INotificationContentText TextBodyGroup3Field1
        {
            get
            {
                return base.TextFields[7];
            }
        }

        public INotificationContentText TextBodyGroup3Field2
        {
            get
            {
                return base.TextFields[8];
            }
        }

        public INotificationContentText TextHeading1
        {
            get
            {
                return base.TextFields[0];
            }
        }

        public INotificationContentText TextHeading2
        {
            get
            {
                return base.TextFields[3];
            }
        }

        public INotificationContentText TextHeading3
        {
            get
            {
                return base.TextFields[6];
            }
        }
    }
}

