using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    public class _Finalizer_finalizeio_finalizeio_finalizeio_
    {
        [OuterLoop]
        [Fact]
        public void _Finalizer_finalizeio_finalizeio_finalizeio_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\Features\\Finalizer\\finalizeio\\finalizeio\\finalizeio.cmd");
        }
    }
}
