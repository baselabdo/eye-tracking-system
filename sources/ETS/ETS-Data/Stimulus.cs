﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Xml.Serialization;
using System.IO;
using System.Drawing.Imaging;
using System.Xml;

namespace ETS_Data
{

    public class Stimulus
    {
        private long id;

        public long Id
        {
            get { return id; }
            set { id = value; }
        }
        private string name;

        public string Name
        {
            get { return string.IsNullOrEmpty(name) ? "" : name.Trim(); }
            set { name = value; }
        }
        private string filename;

        public string Filename
        {
            get { return string.IsNullOrEmpty(filename) ? "" : filename.Trim(); }
            set { filename = value; }
        }
        private StimulusType type;

        public StimulusType Type
        {
            get { return type; }
            set { 
                type = value; 
            }
        }
        private double prob;

        public double Prob
        {
            get { return prob; }
            set { prob = value; }
        }
        private Position pos;

        public Position Pos
        {
            get { return pos; }
            set { pos = value; }
        }

        private Bitmap pictureData;

        public Bitmap PictureData
        {
            get { return pictureData; }
            set { pictureData = value; }
        }

        public string StringType { 
            get {
                switch (Type)
                {
                    case StimulusType.PICTURE:
                        return "Picture";
                    case StimulusType.SOUND:
                        return "Sound";
                    case StimulusType.TEXT:
                        return "Text";
                }
                return "";
            } 
        }
    }
}
