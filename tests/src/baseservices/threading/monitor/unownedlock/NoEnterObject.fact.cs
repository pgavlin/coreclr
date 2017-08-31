using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _monitor_unownedlock_NoEnterObject_NoEnterObject_
    {
        [OuterLoop]
        [Fact]
        public void _monitor_unownedlock_NoEnterObject_NoEnterObject_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\monitor\\unownedlock\\NoEnterObject\\NoEnterObject.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
