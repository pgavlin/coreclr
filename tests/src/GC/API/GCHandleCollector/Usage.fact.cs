using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    public class _GCHandleCollector_Usage_Usage_
    {
        [Fact]
        public void _GCHandleCollector_Usage_Usage_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\API\\GCHandleCollector\\Usage\\Usage.cmd");
        }
    }
}
