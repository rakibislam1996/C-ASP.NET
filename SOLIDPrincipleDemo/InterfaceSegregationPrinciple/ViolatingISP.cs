using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    public interface IGesture
    {
        public void DidTap();
        public void DidDoubleTap();
        public void DidLongTap();
    }
    public class LogInView2 : IGesture
    {
        public void DidTap()
        {
            // Do something
        }
        public void DidDoubleTap()
        {
            // Do something
        }
        public void DidLongTap()
        {
            // Do something
        }
    }
    public class UserView2 : IGesture
    {
        public void DidTap()
        {
            // Do something
        }
        public void DidDoubleTap()
        {
            // Do nothing   , which violates ISP
        }
        public void DidLongTap()
        {
            // Do nothing   , which violates ISP
        }
    }
}
