﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyTechFeedbackGenerator
{
    class TemplateSplitter
    {
        public static List<string> tagList = new List<string>();
        static public List<string> templateSplitter(string templateText)
        {
            string tag;
            string textBlock;
            

            //new array which will split the large 'templateText' variable into smaller ones, based on any whitespace.
            string[] templateSplitter = templateText.Split(' ');
            //List to store all found tags.
            List<string> tempTagList = new List<string>();
            //Go through each string in the array.
            foreach (string templatePortion in templateSplitter)
            {
                //Since foreach varaible cannot be changed, this variable will be used.
                textBlock = templatePortion;
                if (textBlock.Contains("<") && textBlock.Contains(">"))
                {
                    //Sometimes single string may contain multiple tags, this will find all of them and, cut them.
                    while (textBlock.Contains("<") && textBlock.Contains(">"))
                    {
                        tag = textBlock.Substring(textBlock.IndexOf("<"), textBlock.IndexOf(">") + 1);
                        if (tag.EndsWith("<"))
                        {
                            tag = tag.Substring(tag.IndexOf("<"), tag.IndexOf(">") + 1);
                            tempTagList.Add(tag);
                            textBlock = textBlock.Substring(textBlock.IndexOf(">") + 1);
                        }
                        else
                        {
                            tempTagList.Add(tag);
                            textBlock = textBlock.Substring(textBlock.IndexOf(">") + 1);
                        }
                    }
                }
            }
            tagList = tempTagList;
            return tagList;
        }
    }
}
