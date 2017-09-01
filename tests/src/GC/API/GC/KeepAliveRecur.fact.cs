using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    public class _GC_KeepAliveRecur_KeepAliveRecur_
    {
        [OuterLoop]
        [Fact]
        public void _GC_KeepAliveRecur_KeepAliveRecur_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\API\\GC\\KeepAliveRecur\\KeepAliveRecur.cmd");
        }
    }
}
