using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    public class _KeepAlive_keepaliveother_keepalivetypes_keepalivetypes_
    {
        [OuterLoop]
        [Fact]
        public void _KeepAlive_keepaliveother_keepalivetypes_keepalivetypes_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\Features\\KeepAlive\\keepaliveother\\keepalivetypes\\keepalivetypes.cmd");
        }
    }
}
