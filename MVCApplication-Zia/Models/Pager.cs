using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCApplication_Zia.Models
{
    public class Pager
    {
        public int totalItems { get; private set; }
        public int currentPage { get; private set; }
        public int pageSize { get; private set; }
        public int totalPages { get; private set; }
        public int startPage { get; private set; }
        public int endPage { get; private set; }

        public Pager()
        {

        }

        public Pager(int _totalItems, int _page, int _pageSize = 10)
        {
            int _totalPages = (int)Math.Ceiling((decimal)_totalItems / (decimal)_pageSize);

            int _currentPage = _page;

            int _startPage = currentPage - 5;
            int _endPage = currentPage + 4;

            if(startPage <= 0)
            {
                endPage = endPage - (startPage - 1);
                startPage = 1;
            }

            if(endPage > totalPages)
            {
                endPage = totalPages;
                if(endPage > 10)
                {
                    startPage = endPage - 9;
                }
            }

            totalItems = _totalItems;
            currentPage = _currentPage;
            pageSize = pageSize;
            totalPages = _totalPages;
            startPage = _startPage;
            endPage = _endPage;
        }
    }

   
}