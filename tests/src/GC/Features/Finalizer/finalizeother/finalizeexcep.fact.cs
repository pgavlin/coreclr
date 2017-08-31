using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    class _Finalizer_finalizeother_finalizeexcep_finalizeexcep_
    {
        [Fact]
        public void _Finalizer_finalizeother_finalizeexcep_finalizeexcep_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Features\\Finalizer\\finalizeother\\finalizeexcep\\finalizeexcep.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
