using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    public class _Finalizer_finalizeother_finalizearray_finalizearray_
    {
        [Fact]
        public void _Finalizer_finalizeother_finalizearray_finalizearray_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\Features\\Finalizer\\finalizeother\\finalizearray\\finalizearray.cmd");
        }
    }
}
