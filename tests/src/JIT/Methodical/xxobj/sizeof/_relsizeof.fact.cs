using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _xxobj_sizeof__relsizeof__relsizeof_
    {
        [OuterLoop]
        [Fact]
        public void _xxobj_sizeof__relsizeof__relsizeof_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\xxobj\\sizeof\\_relsizeof\\_relsizeof.cmd");
        }
    }
}
