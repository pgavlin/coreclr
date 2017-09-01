using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _monitor_unownedlock_NoEnterObject_NoEnterObject_
    {
        [OuterLoop]
        [Fact]
        public void _monitor_unownedlock_NoEnterObject_NoEnterObject_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\monitor\\unownedlock\\NoEnterObject\\NoEnterObject.cmd");
        }
    }
}
