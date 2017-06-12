﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using DotNetKit.Windows.Documents;

namespace DotNetKit.Wpf.Printing.Demo.Printing
{
    public class Printer
    {
        public void Print<P>(P printable, IPaginator<P> paginator, Size pageSize, PrintQueue printQueue)
        {
            var isLandscape = pageSize.Width > pageSize.Height;
            var mediaSize =
                isLandscape
                    ? new Size(pageSize.Height, pageSize.Width)
                    : pageSize;

            var document = paginator.ToFixedDocument(printable, pageSize);

            var ticket = printQueue.DefaultPrintTicket;
            ticket.PageMediaSize = new PageMediaSize(mediaSize.Width, mediaSize.Height);
            ticket.PageOrientation = PageOrientation.Portrait;

            var writer = PrintQueue.CreateXpsDocumentWriter(printQueue);
            writer.Write(document);
        }
    }
}
