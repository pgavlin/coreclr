using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    public class _Finalizer_finalizeother_finalizenested_finalizenested_
    {
        [OuterLoop]
        [Fact]
        public void _Finalizer_finalizeother_finalizenested_finalizenested_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\Features\\Finalizer\\finalizeother\\finalizenested\\finalizenested.cmd");
        }
    }
}
