using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    public class _GCHandle_Target_Target_
    {
        [OuterLoop]
        [Fact]
        public void _GCHandle_Target_Target_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\API\\GCHandle\\Target\\Target.cmd");
        }
    }
}
