using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _xxobj_sizeof__speed_dbgsizeof64__speed_dbgsizeof64_
    {
        [OuterLoop]
        [Fact]
        public void _xxobj_sizeof__speed_dbgsizeof64__speed_dbgsizeof64_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\xxobj\\sizeof\\_speed_dbgsizeof64\\_speed_dbgsizeof64.cmd");
        }
    }
}
