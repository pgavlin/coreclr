using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    public class _GCHandle_Normal_Normal_
    {
        [OuterLoop]
        [Fact]
        public void _GCHandle_Normal_Normal_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\API\\GCHandle\\Normal\\Normal.cmd");
        }
    }
}
