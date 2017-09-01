using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    public class _GC_KeepAliveNull_KeepAliveNull_
    {
        [OuterLoop]
        [Fact]
        public void _GC_KeepAliveNull_KeepAliveNull_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\API\\GC\\KeepAliveNull\\KeepAliveNull.cmd");
        }
    }
}
