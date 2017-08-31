using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    class _WeakReference_Target_Target_
    {
        [OuterLoop]
        [Fact]
        public void _WeakReference_Target_Target_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\API\\WeakReference\\Target\\Target.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
