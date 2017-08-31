using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    class _Finalizer_finalizeio_finalizeio_finalizeio_
    {
        [OuterLoop]
        [Fact]
        public void _Finalizer_finalizeio_finalizeio_finalizeio_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Features\\Finalizer\\finalizeio\\finalizeio\\finalizeio.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
