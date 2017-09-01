using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    public class _Finalizer_finalizeother_finalizedest_finalizedest_
    {
        [OuterLoop]
        [Fact]
        public void _Finalizer_finalizeother_finalizedest_finalizedest_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\Features\\Finalizer\\finalizeother\\finalizedest\\finalizedest.cmd");
        }
    }
}
