using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _xxobj_sizeof__speed_relsizeof64__speed_relsizeof64_
    {
        [OuterLoop]
        [Fact]
        public void _xxobj_sizeof__speed_relsizeof64__speed_relsizeof64_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\xxobj\\sizeof\\_speed_relsizeof64\\_speed_relsizeof64.cmd");
        }
    }
}
