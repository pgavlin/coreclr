using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    class _WeakReference_IsAlive_neg_IsAlive_neg_
    {
        [OuterLoop]
        [Fact]
        public void _WeakReference_IsAlive_neg_IsAlive_neg_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\API\\WeakReference\\IsAlive_neg\\IsAlive_neg.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
