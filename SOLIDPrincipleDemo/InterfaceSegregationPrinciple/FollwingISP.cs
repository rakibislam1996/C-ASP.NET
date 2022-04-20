using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    public interface ITapGesture
    {
        public void DidTap();
    }
    public interface IDoubleTapGesture
    {
        public void DidDoubleTap();
    }
    public interface ILongTapGesture
    {
        public void DidLongTap();
    }
    public class LogInView : IGesture, ITapGesture, IDoubleTapGesture
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
    public class UserView : ITapGesture
    {
        public void DidTap()
        {
            // Do something
        }
    }
}
