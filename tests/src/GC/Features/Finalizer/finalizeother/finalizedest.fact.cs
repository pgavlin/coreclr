using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    class _Finalizer_finalizeother_finalizedest_finalizedest_
    {
        [OuterLoop]
        [Fact]
        public void _Finalizer_finalizeother_finalizedest_finalizedest_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Features\\Finalizer\\finalizeother\\finalizedest\\finalizedest.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
