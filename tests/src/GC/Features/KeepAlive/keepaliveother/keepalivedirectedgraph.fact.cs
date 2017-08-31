using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    class _KeepAlive_keepaliveother_keepalivedirectedgraph_keepalivedirectedgraph_
    {
        [Fact]
        public void _KeepAlive_keepaliveother_keepalivedirectedgraph_keepalivedirectedgraph_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Features\\KeepAlive\\keepaliveother\\keepalivedirectedgraph\\keepalivedirectedgraph.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
