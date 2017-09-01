using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    public class _Finalizer_finalizeother_finalizeinherit_finalizeinherit_
    {
        [OuterLoop]
        [Fact]
        public void _Finalizer_finalizeother_finalizeinherit_finalizeinherit_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\Features\\Finalizer\\finalizeother\\finalizeinherit\\finalizeinherit.cmd");
        }
    }
}
