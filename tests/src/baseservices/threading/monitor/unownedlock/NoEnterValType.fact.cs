using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _monitor_unownedlock_NoEnterValType_NoEnterValType_
    {
        [OuterLoop]
        [Fact]
        public void _monitor_unownedlock_NoEnterValType_NoEnterValType_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\monitor\\unownedlock\\NoEnterValType\\NoEnterValType.cmd");
        }
    }
}
