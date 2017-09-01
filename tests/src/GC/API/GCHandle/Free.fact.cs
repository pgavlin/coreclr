using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    public class _GCHandle_Free_Free_
    {
        [OuterLoop]
        [Fact]
        public void _GCHandle_Free_Free_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\API\\GCHandle\\Free\\Free.cmd");
        }
    }
}
