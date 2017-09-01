using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    public class _GC_KeepAlive_KeepAlive_
    {
        [OuterLoop]
        [Fact]
        public void _GC_KeepAlive_KeepAlive_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\API\\GC\\KeepAlive\\KeepAlive.cmd");
        }
    }
}
