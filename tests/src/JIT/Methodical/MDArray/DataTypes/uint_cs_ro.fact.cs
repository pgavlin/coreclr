using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _MDArray_DataTypes_uint_cs_ro_uint_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _MDArray_DataTypes_uint_cs_ro_uint_cs_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\MDArray\\DataTypes\\uint_cs_ro\\uint_cs_ro.cmd");
        }
    }
}
