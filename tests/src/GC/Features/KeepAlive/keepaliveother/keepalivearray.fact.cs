using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    public class _KeepAlive_keepaliveother_keepalivearray_keepalivearray_
    {
        [OuterLoop]
        [Fact]
        public void _KeepAlive_keepaliveother_keepalivearray_keepalivearray_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\Features\\KeepAlive\\keepaliveother\\keepalivearray\\keepalivearray.cmd");
        }
    }
}
