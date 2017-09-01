using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    public class _WeakReference_NullHandle_NullHandle_
    {
        [Fact]
        public void _WeakReference_NullHandle_NullHandle_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\API\\WeakReference\\NullHandle\\NullHandle.cmd");
        }
    }
}
