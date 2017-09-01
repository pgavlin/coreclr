using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    public class _KeepAlive_keepaliveother_keepalivehandle_keepalivehandle_
    {
        [OuterLoop]
        [Fact]
        public void _KeepAlive_keepaliveother_keepalivehandle_keepalivehandle_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\Features\\KeepAlive\\keepaliveother\\keepalivehandle\\keepalivehandle.cmd");
        }
    }
}
