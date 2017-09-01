using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _monitor_unownedlock_NoEnterNewObject_NoEnterNewObject_
    {
        [OuterLoop]
        [Fact]
        public void _monitor_unownedlock_NoEnterNewObject_NoEnterNewObject_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\monitor\\unownedlock\\NoEnterNewObject\\NoEnterNewObject.cmd");
        }
    }
}
