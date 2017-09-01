using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    public class _GCHandleCollector_Count_Count_
    {
        [Fact]
        public void _GCHandleCollector_Count_Count_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\API\\GCHandleCollector\\Count\\Count.cmd");
        }
    }
}
