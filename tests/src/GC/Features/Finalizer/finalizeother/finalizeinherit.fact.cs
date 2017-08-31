using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    class _Finalizer_finalizeother_finalizeinherit_finalizeinherit_
    {
        [OuterLoop]
        [Fact]
        public void _Finalizer_finalizeother_finalizeinherit_finalizeinherit_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Features\\Finalizer\\finalizeother\\finalizeinherit\\finalizeinherit.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
