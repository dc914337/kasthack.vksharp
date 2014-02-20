﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using VKSharp.Core.Entities;
using VKSharp.Core.Enums;
using VKSharp.Core.Interfaces;
using VKSharp.Data.Executors;
using VKSharp.Helpers;

namespace VKSharp.Core.EntityParsers.Xml {
    public class AudioParser : DefaultParser<Audio> {
        public override bool UpdateFromFragment( XmlNode node, Audio entity ) {
            Action<Audio, string> parser;
            var nodeName = node.Name;
            if ( GeneratedParsers.TryGetValue( nodeName, out parser ) ) {
                parser( entity, node.InnerText );
                return true;
            }
            switch ( node.Name ) {
                case "genre_id":
                    entity.Genre = (AudioGenre) int.Parse( node.InnerText );
                    break;
                default:
                    return false;
            }
            return true;
        }

    }
}