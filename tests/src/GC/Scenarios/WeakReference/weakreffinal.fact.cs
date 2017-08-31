using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    class _WeakReference_weakreffinal_weakreffinal_
    {
        [OuterLoop]
        [Fact]
        public void _WeakReference_weakreffinal_weakreffinal_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Scenarios\\WeakReference\\weakreffinal\\weakreffinal.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
