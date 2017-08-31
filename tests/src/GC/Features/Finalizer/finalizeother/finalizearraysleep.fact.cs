using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    class _Finalizer_finalizeother_finalizearraysleep_finalizearraysleep_
    {
        [OuterLoop]
        [Fact]
        public void _Finalizer_finalizeother_finalizearraysleep_finalizearraysleep_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Features\\Finalizer\\finalizeother\\finalizearraysleep\\finalizearraysleep.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
