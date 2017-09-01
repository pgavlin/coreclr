using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    public class _KeepAlive_keepaliveother_keepalivefinalize_keepalivefinalize_
    {
        [OuterLoop]
        [Fact]
        public void _KeepAlive_keepaliveother_keepalivefinalize_keepalivefinalize_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\Features\\KeepAlive\\keepaliveother\\keepalivefinalize\\keepalivefinalize.cmd");
        }
    }
}
