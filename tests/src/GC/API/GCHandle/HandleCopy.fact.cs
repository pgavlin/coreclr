using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    public class _GCHandle_HandleCopy_HandleCopy_
    {
        [OuterLoop]
        [Fact]
        public void _GCHandle_HandleCopy_HandleCopy_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\API\\GCHandle\\HandleCopy\\HandleCopy.cmd");
        }
    }
}
