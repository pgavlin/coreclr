using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    public class _KeepAlive_keepaliveother_keepalivescope_keepalivescope_
    {
        [OuterLoop]
        [Fact]
        public void _KeepAlive_keepaliveother_keepalivescope_keepalivescope_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\Features\\KeepAlive\\keepaliveother\\keepalivescope\\keepalivescope.cmd");
        }
    }
}
