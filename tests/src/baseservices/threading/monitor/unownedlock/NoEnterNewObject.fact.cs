using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _monitor_unownedlock_NoEnterNewObject_NoEnterNewObject_
    {
        [OuterLoop]
        [Fact]
        public void _monitor_unownedlock_NoEnterNewObject_NoEnterNewObject_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\monitor\\unownedlock\\NoEnterNewObject\\NoEnterNewObject.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
