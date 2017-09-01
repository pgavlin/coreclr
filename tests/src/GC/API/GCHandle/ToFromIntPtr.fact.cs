using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    public class _GCHandle_ToFromIntPtr_ToFromIntPtr_
    {
        [Fact]
        public void _GCHandle_ToFromIntPtr_ToFromIntPtr_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\API\\GCHandle\\ToFromIntPtr\\ToFromIntPtr.cmd");
        }
    }
}
