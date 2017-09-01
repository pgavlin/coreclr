using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    public class _GC_Finalize_Finalize_
    {
        [OuterLoop]
        [Fact]
        public void _GC_Finalize_Finalize_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\API\\GC\\Finalize\\Finalize.cmd");
        }
    }
}
