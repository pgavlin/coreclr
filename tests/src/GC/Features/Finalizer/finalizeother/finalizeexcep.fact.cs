using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    public class _Finalizer_finalizeother_finalizeexcep_finalizeexcep_
    {
        [Fact]
        public void _Finalizer_finalizeother_finalizeexcep_finalizeexcep_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\Features\\Finalizer\\finalizeother\\finalizeexcep\\finalizeexcep.cmd");
        }
    }
}
