using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _ObjAlloc_ObjAlloc_
    {
        [OuterLoop]
        [Fact]
        public void _ObjAlloc_ObjAlloc_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\ObjAlloc\\ObjAlloc.cmd");
        }
    }
}
