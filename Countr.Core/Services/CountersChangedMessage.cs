using MvvmCross.Plugin.Messenger;

namespace Countr.Core.Services
{
    public class CountersChangedMessage : MvxMessage
    {
        public CountersChangedMessage(object sender)
            : base(sender)
        { }
    }
}
