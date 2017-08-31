using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    class _WeakReference_IsAlive_IsAlive_
    {
        [OuterLoop]
        [Fact]
        public void _WeakReference_IsAlive_IsAlive_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\API\\WeakReference\\IsAlive\\IsAlive.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
