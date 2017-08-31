using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    class _Finalizer_finalizeother_finalizenested_finalizenested_
    {
        [OuterLoop]
        [Fact]
        public void _Finalizer_finalizeother_finalizenested_finalizenested_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Features\\Finalizer\\finalizeother\\finalizenested\\finalizenested.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
