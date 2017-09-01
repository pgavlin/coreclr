using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    public class _Finalizer_finalizeother_finalizearraysleep_finalizearraysleep_
    {
        [OuterLoop]
        [Fact]
        public void _Finalizer_finalizeother_finalizearraysleep_finalizearraysleep_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\Features\\Finalizer\\finalizeother\\finalizearraysleep\\finalizearraysleep.cmd");
        }
    }
}
